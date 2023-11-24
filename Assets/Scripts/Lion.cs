
// INHERITANCE IMPLEMENTED
public class Lion : Animal
{
    public float lionMaxSpeed;

    public override void PrintInformation()
    {
        print("Animal Max Speed " + lionMaxSpeed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = lionMaxSpeed;
        PrintInformation();
    }
}
