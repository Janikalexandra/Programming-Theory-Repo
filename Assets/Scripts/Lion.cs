
// INHERITANCE IMPLEMENTED
public class Lion : Animal
{

    public override void PrintInformation(float speed)
    {
        print("Animal Max Speed " + speed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = 50;
        PrintInformation(50);
    }
}
