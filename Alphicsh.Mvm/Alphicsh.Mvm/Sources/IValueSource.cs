namespace Alphicsh.Mvm.Sources;

public interface IValueSource<TValue>
{
    TValue Value { get; set; }
    event EventHandler<ValueChangedEventArgs<TValue>>? ValueChanged;
}
