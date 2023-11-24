
// INHERITANCE IMPLEMENTED
public class Dog : Animal
{
    public float dogMaxSpeed;
    public override void PrintInformation()
    {
        print("Animal Max Speed " + dogMaxSpeed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = dogMaxSpeed;
        PrintInformation();
    }
}
