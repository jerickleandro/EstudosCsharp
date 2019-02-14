using Cap10AbstractMethod.Entities.Enums;

namespace Cap10AbstractMethod.Entities {
    abstract class Shape {
        public Color Color { get; set; }

        public Shape() { }
        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();

    }
}
