namespace Parcial2.Game
{
    public class PlayerProfile
    {
        public int Currency { get; private set; }

        public int Experience { get; private set; }

        public PlayerProfile(int newCurrency)
        {
            Currency = newCurrency;
        }

        public void UpdateCurrency(int currencyAdd)
        {
            Currency += currencyAdd;
        }

        public void UpdateExperience(int experienceAdd)
        {
            Experience += experienceAdd;
        }
    }
}