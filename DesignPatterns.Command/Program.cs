using DesignPatterns.Command;

var turnLightCmd = new TurnOnLightCommand();
turnLightCmd.Execute();
Home.Shared.Status();
turnLightCmd.Undo();
Home.Shared.Status();

var adjustThermostatCmd = new AdjustThermostatCommand();
adjustThermostatCmd.Execute();
Home.Shared.Status();

var lockDoorCmd = new LockDoorCommand();
lockDoorCmd.Execute();
Home.Shared.Status();