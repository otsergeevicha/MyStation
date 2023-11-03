using System;

namespace Services.Wallet
{
    public interface IWallet
    {
        event Action<int> Changed;
        
        bool Check(int pricePurchase);

        void Spend(int price);

        void Apply(int amountReplenishment);

    }
}