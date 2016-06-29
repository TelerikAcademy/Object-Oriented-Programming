namespace Societies.Core.Contracts
{
    using Infrastructure.Enumerations.Human;
    using System.Collections.Generic;

    public interface IHuman : INameable
    {
        int Id { get; }
        int Age { get; }
        GenderType Gender { get; }
        ReligionType Religion { get; }
        RaceType Race { get; }
        HairColorType HairColor { get; }
        EyesColorType EyesColor { get; }
        FaceShapeType FaceShape { get; }

        int VitalityLevel { get; }
        int StarvationLevel { get; }
        int ThirstLevel { get; }

        void Eat(ICollection<IFood> food);
        void Drink(ICollection<IBeverage> beverage);
        void Work(int hours);
        void Sleep(int hours);
        void Rest(int minutes);

        decimal Pay(decimal amountToBePayed);
    }
}
