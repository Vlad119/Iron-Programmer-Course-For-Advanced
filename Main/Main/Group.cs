using System.Collections.Generic;

public class Group
{
    public List<Student> Students { get; set; } = new List<Student>();
    public static Group operator +(Group g1, Group g2)
    {
        Group newGroup = new Group();
        if (g1.Students != null)
        {
            newGroup.Students.AddRange(g1.Students);
        }
        if (g2.Students != null)
        {
            newGroup.Students.AddRange(g2.Students);
        }
        return newGroup;
    }
}
