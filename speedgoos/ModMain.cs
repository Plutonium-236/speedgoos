using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GooseShared;

namespace Honcker
{
	// Token: 0x02000002 RID: 2
	public class ModMain : IMod
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x06000002 RID: 2
		public void Init()
		{
			InjectionPoints.PreTickEvent += this.PreTick;
		}

		// Token: 0x06000003 RID: 3
		public void PreTick(GooseEntity goose)
		{
			if (ModMain.GetAsyncKeyState(Keys.F7) != 0)
			{
				API.Goose.setSpeed(goose, GooseEntity.SpeedTiers.Walk);
				return;
			}
			if (ModMain.GetAsyncKeyState(Keys.F8) != 0)
			{
				API.Goose.setSpeed(goose, GooseEntity.SpeedTiers.Run);
				return;
			}
			if (ModMain.GetAsyncKeyState(Keys.F9) != 0)
			{
				API.Goose.setSpeed(goose, GooseEntity.SpeedTiers.Charge);
				return;
			}
			if (ModMain.GetAsyncKeyState(Keys.F9) != 0)
			{
				API.Goose.setSpeed(goose, GooseEntity.SpeedTiers.Charge);
				return;
			}
			if (ModMain.GetAsyncKeyState(Keys.F11) != 0)
			{
				goose.parameters.WalkSpeed = 200f;
				goose.parameters.RunSpeed = 500f;
				goose.parameters.ChargeSpeed = 1000f;
				goose.currentSpeed = 200f;
				return;
			}
			if (ModMain.GetAsyncKeyState(Keys.F10) != 0)
			{
				goose.parameters.WalkSpeed = 80f;
				goose.parameters.RunSpeed = 200f;
				goose.parameters.ChargeSpeed = 400f;
				API.Goose.setSpeed(goose, GooseEntity.SpeedTiers.Walk);
				return;
			}
		}
	}
}
