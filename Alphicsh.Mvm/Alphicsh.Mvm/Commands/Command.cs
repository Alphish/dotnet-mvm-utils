using System.Windows.Input;

namespace Alphicsh.Mvm.Commands;

public static class Command
{
    // --------
    // Commands
    // --------

    public static ICommand From(Action executionAction)
        => new PlainCommand(executionAction);

    public static ICommand From<TParameter>(Action<TParameter> executionAction, bool isRequired = true)
        => new PlainCommand(UntypedParameterAction(executionAction, isRequired));

    public static IConditionalCommand From(Func<bool> executionPredicate, Action executionAction)
        => new PredicateCommand(executionPredicate, executionAction);

    public static IConditionalCommand From<TParameter>(
        Func<TParameter, bool> executionPredicate,
        Action<TParameter> executionAction,
        bool isRequired = true
        )
    {
        return new PredicateCommand(
            UntypedParameterCondition(executionPredicate, isRequired),
            UntypedParameterAction(executionAction, isRequired)
            );
    }

    // -------
    // Helpers
    // -------

    private static Action<object?> UntypedParameterAction<TParameter>(Action<TParameter> typedAction, bool isRequired)
    {
        return (object? parameter) =>
        {
            if (parameter == null)
            {
                if (isRequired)
                    throw new ArgumentException($"A parameter cannot be null.");

                typedAction(default!);
                return;
            }

            if (parameter is not TParameter typedParameter)
                throw new ArgumentException($"A parameter of type {typeof(TParameter).Name} is required.");

            typedAction(typedParameter);
        };
    }

    private static Func<object?, bool> UntypedParameterCondition<TParameter>(Func<TParameter, bool> typedCondition, bool isRequired)
    {
        return (object? parameter) =>
        {
            if (parameter == null)
            {
                return !isRequired && typedCondition(default!);
            }

            if (parameter is not TParameter typedParameter)
                return false;

            return typedCondition(typedParameter);
        };
    }
}
