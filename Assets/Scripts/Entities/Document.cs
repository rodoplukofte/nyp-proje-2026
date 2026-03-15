public enum DocumentType
{
    Passport,
    CustomsDeclaration,
    VehicleCard
}

public class Document
{
    public DocumentType Type;
    public string OwnerName;
    public string ExpiryDate;
    public bool HasError;
    public string ErrorDescription;

    public Document(DocumentType type, string ownerName, string expiryDate)
    {
        Type = type;
        OwnerName = ownerName;
        ExpiryDate = expiryDate;
        HasError = false;
        ErrorDescription = "";
    }

    public bool IsExpired()
    {
        // Tarih kontrolü ileride buraya gelecek
        return false;
    }
}