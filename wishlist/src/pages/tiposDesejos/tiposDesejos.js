import { Component } from 'react';
class tiposDejesos extends Component{
    constructor(props){
        super(props);
        this.state={
            listartiposDesejos : [],
            nometiposDesejos : '',
            idTiposDesejos : 0
        }
    }
    buscartiposDesejos = () =>{
        console.log('agora vamos fazer a chamada para a API')
        
        fetch('http://localhost:5000/api/tiposDesejos')

        .then(resposta => resposta.json())

        .then(data => this.setState({listartiposDesejos : data}))

        .catch( erro => console.log(erro))
    }
    atualizaEstadonometiposDesejos = async (evento) =>{
        await this.setState({nometiposDesejos : evento.target.value})
        console.log(this.state.nometiposDesejos)
    };
    
    cadastrartiposDesejos=(event) =>{
        event.preventDefault();

        if (this.state.idTiposDesejosAlterado !==0) {
           
            fetch('http://localhost:5000/api/tiposDesejos/' + this.state.idTiposDesejosAlterado,
            {
                method : 'PUT',
                body : JSON.stringify({nometiposDesejos : this.state.idTiposDesejosAlterado}),

                headers : {
                    "Content-Type" : "application/json"
                }
            })


            .then(resposta => {
                if (resposta.status === 204) {
                   console.log(
                       'tipo de desejo' + this.state.idTiposDesejosAlterado + ' atualizado!',
                       'Seu novo desejo é:' + this.state.nometiposDesejos
                   ) 
                }
            })
            
            .then(this.buscartiposDesejos)
            .then(this.limparCampos)
        }
        
        else
        {
            fetch('http://localhost:5000/api/tiposDesejos',{
                method : 'POST',
                body : JSON.stringify({nometiposDesejos : this.state.nometiposDesejos}),
                headers : {
                    "Content-Type" : "application/json"
                }
            })
            .then(console.log("Tipo de Desejo cadastrado!"))
            .catch(error => console.log(error))
            .then(this.buscartiposDesejos)
            .then(this.limparCampos)
        }

    }

    componentDidMount(){
        this.buscartiposDesejos();
    }

    buscartiposDesejosPorid = (tiposDejesos) => {
        this.setState({
            idTiposDesejosAlterado : tiposDejesos.idTiposDesejos,
            nometiposDesejos : tiposDejesos.nometiposDesejos
        }, () => {
            console.log(
                // Exibe no console do navegador o valor do ID do Tipo de Evento recebido
                'O Tipo de Desejo ' + tiposDejesos.idTiposDesejos + ' foi selecionado,',
                // o valor do state idTipoEventoAlterado
                'agora o valor do state idTiposDesejosAlterado é: ' + this.state.idTipoEventoAlterado,
                // e o valor do state titulo
                'e o valor do state nometiposDesejos é: ' + this.state.nometiposDesejos
            )
        } )
    }

    limparCampos = () => {
        this.setState({
            nometiposDesejos : '',
            idTiposDesejosAlterado : 0
        })
        console.log('Os states foram resetados!')
    }

    render(){
        return(
            <div>
                <main>
                    <section>
                        <h2>Lista de Desejos</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>#</th>{/* IDs */}
                                    <th>Nome do Dejeso</th>{/* Títulos */}
                                    <th>Ações</th>{/* Ações */}
                                </tr>
                            </thead>
                                
                            <tbody>
                                {
                                    //          Array
                                    this.state.listartiposDesejos.map( (tiposDejesos) => {
                                        return (
                                            <tr key={tiposDejesos.idTiposDesejos}>
                                                <td>{tiposDejesos.idTiposDesejos}</td>
                                                <td>{tiposDejesos.nometiposDesejos}</td>
                                                <td><button onClick={() => this.buscartiposDesejosPorid(tiposDejesos)}>Editar</button></td>
                                            </tr>
                                        )
                                    } )
                                }
                            </tbody>
                        </table>
                    </section>

                    <section>
                        <h2>Cadastrode de Desejos</h2>
                        
                        <form onSubmit={this.cadastrartiposDesejos}>
                            <div>
                                <input
                                    type="text"
                                    value={this.state.nometiposDesejos}
                                    onChange={this.atualizaEstadonometiposDesejos}
                                    placeholder="Título do Tipo de Desejo"
                                />

                                <button type="submit" disabled={this.state.nometiposDesejos === '' ? 'none' : ''}>
                                    {
                                        this.state.idTiposDesejosAlterado === 0 ? 'Cadastrar' : 'Atualizar'
                                    }
                                </button>

                                <button type="button" onClick={this.limparCampos}>
                                    Cancelar
                                </button>
                            </div>
                        </form>

                        {
                            this.state.idTiposDesejosAlterado !== 0 &&
                            <div>
                                <p>O Desejo {this.state.idTiposDesejosAlterado} está sendo editado!</p>
                                <p>Clique em Cancelar caso queira cancelar a operação antes de cadastrar um novo Desejo.</p>
                            </div>
                        }
                    </section>
                </main>
            </div>
        );
    }
}
export default tiposDejesos;