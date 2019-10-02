namespace MyOwnExercise
{
    public interface ICreature : IThing, IWeighable, IMoveable
    {
        string Name { get; }
        int Age { get; }
        genders Gender { get; }

        void Poop();

        void Eat();

        void Drink();
    }
}