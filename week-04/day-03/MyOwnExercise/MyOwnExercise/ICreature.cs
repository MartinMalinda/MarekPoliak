namespace MyOwnExercise
{
    public interface ICreature
    {
        string Name { get; }
        int Age { get; }
        genders Gender { get; }

        void Poop();

        void Eat();

        void Drink();
    }
}