static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (department is null && id is null){
            return $"{name} - OWNER";
        }
        else if (id is null) {
            return $"{name} - {department.ToUpper()}";
        }
        else if (department is null){
            return $"[{id}] - {name} - OWNER";
        } 
        return $"[{id}] - {name} - {department.ToUpper()}";
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    } 
}
