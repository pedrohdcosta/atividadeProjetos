ICarro carro = new Carro();
ICarro CorDacorator = new CorDacorator(carro);

Console.Write(CorDacorator.GetCarroType());