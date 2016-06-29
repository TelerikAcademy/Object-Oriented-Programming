namespace Societies.Core.Models.Humans
{
    using System;

    using Abstract;
    using Infrastructure.Constants;
    using Infrastructure.Enumerations.Human;

    [Serializable]
    public class SoftwareEngineer : Human
    {
        public SoftwareEngineer(
            string name,
            int age,
            HairColorType hairColor,
            EyesColorType eyesColor,
            FaceShapeType faceShape,
            RaceType race,
            GenderType gender,
            ReligionType religion)
            : base(name, age, hairColor, eyesColor, faceShape, race, gender, religion)
        {
        }

        public override decimal Pay(decimal amountToBePayed)
        {
            var bakshish =
                amountToBePayed * CurrencyConstants.SoftwareEngineerBakshishPercentage;

            return base.Pay(amountToBePayed + bakshish);
        }
    }
}