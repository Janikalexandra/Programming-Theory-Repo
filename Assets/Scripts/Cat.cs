
// INHERITANCE IMPLEMENTED
public class Cat : Animal
{
    public override void PrintInformation(float speed)
    {
        print("Animal Max Speed " + speed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = 40;
        PrintInformation(40);
    }
}
