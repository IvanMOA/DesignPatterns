import 'dart:math';

enum ShapeType { Triangle, Circle }

class Circle implements Shape {
  @override
  void draw() {
    print('Drawing a circle...');
  }
}

class Triangle implements Shape {
  @override
  void draw() {
    print('Drawing a triangle...');
  }
}

abstract class Shape {
  factory Shape(ShapeType type) {
    switch (type) {
      case ShapeType.Circle:
        return Circle();
        break;
      case ShapeType.Triangle:
        return Triangle();
        break;
      default:
        throw Error();
        break;
    }
  }
  void draw();
}

void main(List<String> arguments) {
  final circle = Shape(ShapeType.Circle);
  circle.draw();
  final triangle = Shape(ShapeType.Triangle);
  triangle.draw();
}
