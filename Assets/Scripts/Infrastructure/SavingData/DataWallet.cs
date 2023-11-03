using System;

namespace Infrastructure.SavingData
{
    [Serializable]
    public class DataWallet
    {
        public int Money = 0;
        
        public int Read() =>
            Money;

        public void Record(int amountMoney) => 
            Money = amountMoney;
    }
}