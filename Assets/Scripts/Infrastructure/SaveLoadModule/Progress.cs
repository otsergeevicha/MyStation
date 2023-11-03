using System;
using Infrastructure.SavingData;

namespace Infrastructure.SaveLoadModule
{
    [Serializable]
    public class Progress
    {
        public DataWallet DataWallet { get; }

        public Progress() => 
            DataWallet = new DataWallet();
    }
}