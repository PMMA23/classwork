package Pet;

/************************************************************
 * This class will represent pet information for a pet
 *
 *
 * Every class has data
 *          Name of pet
 *          Type of pet
 *          Gender
 *          Weight (lbs)
 *          Is is spayed or netured
 *
 * Behavior (methods):
 *
 * 1. you should always have at least on constructor to the class
 *      a default ctar ( in case Java needs it; Java uses the default constructor
 *
 *      a least one ctar that takes agruments used to intiliaze the object
 *
 */
public class Pet {
/****************************************************************************************
 * Member Data
 */
 private String petName
    private String petType;
private char petGender;
private int petWeight;
private boolean isSpayed;

/*****************************************************************************
 * Constructors - intiliaze objects instantiated for a class for a class
 *
 *
 */
// Default ctor - define an
    public Pet(){}

    public Pet(String petName, String petType, char petGender, int petWeight, boolean isSpayed) {
       // this. used in these statements
        //
        this.petName = petName;
        this.petType = petType;
        this.petGender = petGender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;
    }
}
// when u want to create a class first thing u want to do is create a package
