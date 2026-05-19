using Acme.BookStore.Books;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

[Mapper]
public partial class BookToBookDtoMapper : MapperBase<Book, BookDto>
{
    public override BookDto Map(Book source)
    {
        if (source == null) return null!;

        var destination = new BookDto();
        Map(source, destination);
        return destination;
    }

    public override void Map(Book source, BookDto destination)
    {
        if (source == null || destination == null) return;

        destination.Id = source.Id;
        destination.Language = source.Language;
        destination.Name = source.Name;
        destination.Type = source.Type;
        destination.PublishDate = source.PublishDate;
        destination.Price = source.Price;
    }
}

[Mapper]
public partial class CreateUpdateBookDtoToBookMapper : MapperBase<CreateUpdateBookDto, Book>
{
    public override Book Map(CreateUpdateBookDto source)
    {
        if (source == null) return null!;

        var destination = new Book();
        Map(source, destination);
        return destination;
    }

    public override void Map(CreateUpdateBookDto source, Book destination)
    {
        if (source == null || destination == null) return;

        destination.Name = source.Name;
        destination.Language = source.Language;
        destination.Type = source.Type;
        destination.PublishDate = source.PublishDate;
        destination.Price = source.Price;
    }
}
[Mapper]
public partial class BookDtoToCreateUpdateBookDtoMapper : MapperBase<BookDto, CreateUpdateBookDto>
{
    public override CreateUpdateBookDto Map(BookDto source)
    {
        if (source == null) return null!;
        var destination = new CreateUpdateBookDto();
        Map(source, destination);
        return destination;
    }
    public override void Map(BookDto source, CreateUpdateBookDto destination)
    {
        if (source == null || destination == null) return;
        destination.Name = source.Name;
        destination.Language = source.Language;
        destination.Type = source.Type;
        destination.PublishDate = source.PublishDate;
        destination.Price = source.Price;
    }
}