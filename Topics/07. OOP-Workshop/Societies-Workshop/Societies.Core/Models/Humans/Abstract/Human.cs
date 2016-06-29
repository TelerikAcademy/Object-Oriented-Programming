namespace Societies.Core.Models.Humans.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Infrastructure.Constants;
    using Infrastructure.Enumerations.Human;
    using Infrastructure.Utils;
    using Infrastructure.Exceptions;

    [Serializable]
    public class Human : IHuman
    {
        private readonly int id;
        private readonly int age;
        private readonly string name;
        private readonly HairColorType hairColor;
        private readonly EyesColorType eyesColor;
        private readonly FaceShapeType faceShape;
        private readonly ReligionType religion;
        private readonly GenderType gender;
        private readonly RaceType race;
        private decimal moneyInEuro;
        private int vitalityLevel;
        private int starvationLevel;
        private int thirstLevel;

        private Human()
        {
            this.vitalityLevel = ValidationConstants.VitalityLevelMaxValue;
            this.starvationLevel = ValidationConstants.StarvationLevelMaxValue;
            this.thirstLevel = ValidationConstants.ThirstLevelMaxValue;
            this.moneyInEuro = ValidationConstants.MoneyInEuroMinValue;
        }

        public Human(
            string name,
            int age,
            HairColorType hairColor,
            EyesColorType eyesColor,
            FaceShapeType faceShape,
            RaceType race,
            GenderType gender,
            ReligionType religion)
            : this()
        {
            this.id = DataGenerator.GenerateUniqueId();

            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
            this.faceShape = faceShape;
            this.eyesColor = eyesColor;
            this.religion = religion;
            this.gender = gender;
            this.race = race;
        }

        public EyesColorType EyesColor
        {
            get { return this.eyesColor; }
        }

        public FaceShapeType FaceShape
        {
            get { return this.faceShape; }
        }

        public GenderType Gender
        {
            get { return this.gender; }
        }

        public HairColorType HairColor
        {
            get { return this.hairColor; }
        }

        public RaceType Race
        {
            get { return this.race; }
        }

        public ReligionType Religion
        {
            get { return this.religion; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public int Id
        {
            get { return this.id; }
        }

        public int VitalityLevel
        {
            get
            {
                return this.vitalityLevel;
            }
            private set
            {
                if (value < ValidationConstants.VitalityLevelMinValue)
                {
                    this.vitalityLevel = ValidationConstants.VitalityLevelMinValue;
                }
                else if (value > ValidationConstants.VitalityLevelMaxValue)
                {
                    this.vitalityLevel = ValidationConstants.VitalityLevelMaxValue;
                }
                else
                {
                    this.vitalityLevel = value;
                }
            }
        }

        public int StarvationLevel
        {
            get
            {
                return this.starvationLevel;
            }
            private set
            {
                if (value < ValidationConstants.StarvationLevelMinValue)
                {
                    this.starvationLevel = ValidationConstants.StarvationLevelMinValue;
                }
                else if (value > ValidationConstants.StarvationLevelMaxValue)
                {
                    this.starvationLevel = ValidationConstants.StarvationLevelMaxValue;
                }
                else
                {
                    this.starvationLevel = value;
                }
            }
        }

        public int ThirstLevel
        {
            get
            {
                return this.thirstLevel;
            }
            private set
            {
                if (value < ValidationConstants.ThirstLevelMinValue)
                {
                    this.thirstLevel = ValidationConstants.ThirstLevelMinValue;
                }
                else if (value > ValidationConstants.ThirstLevelMaxValue)
                {
                    this.thirstLevel = ValidationConstants.ThirstLevelMaxValue;
                }
                else
                {
                    this.thirstLevel = value;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
        }

        public void Drink(ICollection<IBeverage> beverage)
        {
            Console.WriteLine(new string('=', GlobalConstants.DelimitersCount));
            Console.WriteLine($"{this.Name}: - \"I am drinking\"");
        }

        public void Eat(ICollection<IFood> food)
        {
            Console.WriteLine(new string('=', GlobalConstants.DelimitersCount));
            Console.WriteLine($"{this.Name}: - \"I am eating\"");
        }

        public void Rest(int minutes)
        {
            this.VitalityLevel += (int)(minutes * GlobalConstants.VitalityRestorationRateWhileResting);
        }

        public void Sleep(int hours)
        {
            this.VitalityLevel += hours * GlobalConstants.VitalityRestorationRateWhileSleeping;
        }

        public void Work(int hours)
        {
            this.moneyInEuro += hours * CurrencyConstants.SoftwareEngineerSalaryPerHour;
        }

        public virtual decimal Pay(decimal amountToBePayed)
        {
            if(this.moneyInEuro >= amountToBePayed)
            {
                this.moneyInEuro -= amountToBePayed;
                return amountToBePayed;
            }
            else
            {
                throw new MoneyOutOfRangeException("Nqmam kesh", amountToBePayed);
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder(500);

            builder.AppendLine(new string('=', GlobalConstants.DelimitersCount));
            builder.AppendLine($"Id: {this.Id}");
            builder.AppendLine($"Name: {this.Name}");
            builder.AppendLine($"Age: {this.Age}");
            builder.AppendLine($"Vitality level: {this.VitalityLevel}/{ValidationConstants.VitalityLevelMaxValue}");
            builder.AppendLine($"Starvation level: {this.StarvationLevel}/{ValidationConstants.StarvationLevelMaxValue}");
            builder.AppendLine($"Thirst level: {this.ThirstLevel}/{ValidationConstants.ThirstLevelMaxValue}");
            builder.AppendLine($"Race: {this.Race}");
            builder.AppendLine($"Gender: {this.Gender}");
            builder.AppendLine($"Religion: {this.Religion}");
            builder.AppendLine($"Face shape: {this.FaceShape}");
            builder.AppendLine($"Eyes color: {this.EyesColor}");
            builder.AppendLine($"Hair color: {this.HairColor}");
            builder.AppendLine($"Money in euro: ${this.moneyInEuro}");
            builder.AppendLine(new string('=', GlobalConstants.DelimitersCount));

            return builder.ToString();
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
    }
}