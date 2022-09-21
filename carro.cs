
interface ICarro{

    string GetCarroType();

}



class Carro : ICarro{

    public string GetCarroType(){

        return "Modelo basico";

    }
}

class CarroDecorator : ICarro {

    private ICarro _carro;

    public CarroDecorator(ICarro carro){
        
        _carro = carro;

    }

    public virtual string GetCarroType(){
        
        return _carro.GetCarroType();
    }

}

class CorDacorator : CarroDecorator{

    public CorDacorator(ICarro carro) : base(carro){}

    public override string GetCarroType(){

        string cor = base.GetCarroType();
        cor +=  " de cor preta";
        return cor;
    }
}
