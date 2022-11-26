class Plant {
  final int plantId;
  final int number;

  final String category;
  final String instName;
  final String imageURL;
  bool isFavorated;
  final String decription;
  bool isSelected;

  Plant(
      {required this.plantId,
      required this.number,
      required this.category,
      required this.instName,
      required this.imageURL,
      required this.isFavorated,
      required this.decription,
      required this.isSelected});

  //List of Plants data
  static List<Plant> plantList = [
    Plant(
        plantId: 0,
        number: 118,
        category: 'Policia',
        instName: 'Nacional Nicaragua',
        imageURL: 'assets/images/P1_Logo_P_Nacional.png',
        isFavorated: true,
        decription:
            'La Policía Nacional de Nicaragua es la institución de carácter civil'
            'encargada de garantizar la seguridad y el orden público en el territorio nicaragüense.',
        isSelected: false),
    Plant(
        plantId: 1,
        number: 128,
        category: 'Cruz Roja',
        instName: 'Nicaragüense',
        imageURL: 'assets/images/P1_Logo_Cruz_Rojav.png',
        isFavorated: false,
        decription:
            'La Cruz Roja Nicaragüense es una asociación humanitaria de carácter voluntario'
            'privada y sin fines de lucro, auxiliar de los poderes públicos.',
        isSelected: false),
    Plant(
        plantId: 2,
        number: 115,
        category: 'Benemerito Cuerpo',
        instName: 'Bomberos',
        imageURL: 'assets/images/P1_Logo_Bomberos.png',
        isFavorated: false,
        decription:
            'Servicios de emergencia y rescate y protección contra incendios'
            'trabaja con el fin de salvaguardar la vida de las familias Nicaragüenses.',
        isSelected: false),
    Plant(
        plantId: 3,
        number: 2264 - 7630,
        category: 'MINSA',
        instName: 'Ministerio de Salud',
        imageURL: 'assets/images/minsa.png',
        isFavorated: false,
        decription:
            'Un sistema de salud que atiende a los nicaragüenses según sus necesidades y '
            'garantiza el acceso gratuito y universal a los servicios de salud.',
        isSelected: false),
  ];
}
