import 'dart:math';

abstract class Entity {
  String name;
  int damage;
  int health;
  void attack(Entity entity) {
    var newHealth = entity.health - damage;
    print(
        '$name $health HP attacked ${entity.name} (${entity.health} => ${newHealth})');
    entity.setHealth(newHealth);
  }

  void setHealth(int health) {
    this.health = health;
  }
}

class Player extends Entity {
  Player({String name, int damage, int health}) {
    this.name = name;
    this.damage = damage;
    this.health = health;
  }
}

abstract class PlayerFactory {
  Player createPlayer();
}

class NormalPlayerFactory extends PlayerFactory {
  @override
  Player createPlayer({String name, int damage, int health}) {
    return Player(damage: damage, name: name, health: health);
  }
}

abstract class Enemy extends Entity {}

class Werewolf extends Enemy {
  Werewolf({String name, int damage, int health}) {
    this.name = name;
    this.damage = damage;
    this.health = health;
  }
}

abstract class EnemyFactory {
  Enemy createEnemy();
}

class WerewolfFactory extends EnemyFactory {
  @override
  Enemy createEnemy({int damage, int health, String name}) {
    return Werewolf(damage: damage, health: health, name: name);
  }
}

class RandomStatsWerewolfFactory extends EnemyFactory {
  @override
  Enemy createEnemy({String name}) {
    var randomDamage = Random().nextInt(100);
    var randomHealth = Random().nextInt(100);
    return Werewolf(damage: randomDamage, health: randomHealth, name: name);
  }
}

void main(List<String> arguments) {
  var randomStatsWwFactory = RandomStatsWerewolfFactory();
  var playerFactory = NormalPlayerFactory();
  var werewolfBoss = randomStatsWwFactory.createEnemy(name: 'Epic boss');
  var playerOne =
      playerFactory.createPlayer(name: 'Steve', damage: 3, health: 20);
  playerOne.attack(werewolfBoss);
  werewolfBoss.attack(playerOne);
}
