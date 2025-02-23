﻿namespace Alphicsh.Mvm.ViewModels;

public interface IViewModelProperty : IDisposable
{
}

public interface IViewModelProperty<TValue> : IViewModelProperty
{
    event EventHandler<ValueChangedEventArgs<TValue>>? ValueChanged;
    void RaiseValueChanged(TValue oldValue, TValue newValue);
}
