using System;
using System.Timers;
using TradeHelper.Auth;
using TradeHelper.Auth.Outpost;
using TradeHelper.Data.Trade;

namespace TradeHelper.Data.Bump.Outpost
{
	class BumpService : IBumpService
	{
		private AuthService auth;
		private static Credentials creds;
		private Timer timer;

		public BumpService()
		{
			auth = new AuthService();
			creds = auth.GetCreds();
		}

		public void BumpAll(object sender = null, EventArgs e = null)
		{
			throw new NotImplementedException();
		}

		public void Bump(int tradeId)
		{
			throw new NotImplementedException();
		}

		public void Bump(TradeItem trade)
		{
			throw new NotImplementedException();
		}
	}
}