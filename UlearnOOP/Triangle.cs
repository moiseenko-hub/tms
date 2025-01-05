namespace UlearnOOP;

public class Triangle
{
    class Triangle{
        public Point A {get;set;}
        public Point B {get;set;}
        public Point C {get;set;}

        public override string ToString(){
            return $"({A.ToString()}) ({B.ToString()}) ({C.ToString()})";
        }
    }
}