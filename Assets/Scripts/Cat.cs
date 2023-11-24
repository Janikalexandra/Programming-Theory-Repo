
// INHERITANCE IMPLEMENTED
public class Cat : Animal
{
    public float catMaxSpeed;
    public override void PrintInformation()
    {
        print("Animal Max Speed " + catMaxSpeed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = catMaxSpeed;
        PrintInformation();
    }
}
