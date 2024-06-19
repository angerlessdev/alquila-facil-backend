namespace AlquilaFacilPlatform.Locals.Domain.Model.Commands;

public record CreateLocalCommand(
    string District, string Street, string LocalType, string Country, string City, int Price, string PhotoUrl, int LocalCategoryId
    );