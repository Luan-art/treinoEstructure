namespace Models
{
    public class Car
    {
        public readonly string Insert = "INSERT INTO TB_CAR (name, color, year) VALUES (@name, @color, @year)";
        public readonly string Update = "UPDATE TB_CAR set name = @name, color = @color, year = @year WHERE id = @id";
        public readonly string Delete = "Delete from TB_CAR WHERE id = @id";
        public readonly string Get = "SELECT id, name, color, year FROM TB_CAR Where id = @id";
        public readonly string GetAll = "SELECT id, name, color, year FROM TB_CAR";

        public int id {  get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int year { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Nome: {name}, Color: {color}, ano: {year}";
        }
    }
}
