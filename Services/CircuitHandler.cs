using Microsoft.AspNetCore.Components.Server.Circuits;

public class CustomCircuitHandler : CircuitHandler
{
    public bool IsConnected { get; private set; } = false;

    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        IsConnected = true;
        return base.OnCircuitOpenedAsync(circuit, cancellationToken);
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        IsConnected = false;
        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }
}
