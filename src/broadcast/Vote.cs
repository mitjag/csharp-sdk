using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.broadcast
{
    public class Vote
    {
        public long ProposalId { get; set; }

        public int Option { get; set; }
    }
}
