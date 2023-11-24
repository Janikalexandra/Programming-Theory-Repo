
// INHERITANCE IMPLEMENTED
public class Dog : Animal
{

    public override void PrintInformation(float speed)
    {
        print("Animal Max Speed " + speed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = 35;
        PrintInformation(35);
    }
}
