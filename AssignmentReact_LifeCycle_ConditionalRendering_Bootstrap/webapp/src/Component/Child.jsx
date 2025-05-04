import React from "react"
import GrandChild from "./GrandChild"
import "./Child.css"
import Calculator from './Calculator'
import StudentTable from './StudentTable'


const studentsData = [
    { "name": "Aarav", "math": 85, "science": 90, "english": 88 },
    { "name": "Ananya", "math": 78, "science": 82, "english": 75 },
    { "name": "Vivaan", "math": 92, "science": 88, "english": 91 },
    { "name": "Diya", "math": 70, "science": 75, "english": 80 },
    { "name": "Rohan", "math": 88, "science": 92, "english": 86 },
    { "name": "Meera", "math": 60, "science": 65, "english": 70 },
    { "name": "Arjun", "math": 95, "science": 94, "english": 93 },
    { "name": "Kavya", "math": 82, "science": 79, "english": 85 },
    { "name": "Yash", "math": 76, "science": 80, "english": 78 },
    { "name": "Isha", "math": 89, "science": 91, "english": 87 },
    { "name": "Disha", "math": 32, "science": 35, "english": 37 },
]

class Child extends React.Component {

    constructor() {
        super()
        this.state = {
            name: "",
            show: true
        }
    }


    componentDidMount() {
        console.log("componentDidMount Child.");
    }


    componentWillUnmount() {
        console.log("componentWillUnmount Child.");
    }

    handleInput = (e) => {
        this.setState({ name: e.target.value })
    }

    toggleShow = () => {
        this.setState((prevState) => ({ show: !prevState.show }))
    }

    clearInputFiled = () => {
        this.setState({ name: "" })
    }

    render() {
        return (
            <>
                {
                    this.state.show ?
                        <div className="input-container">
                            <input
                                type="text"
                                id='name'
                                value={this.state.name}
                                placeholder='Enter your name.....'
                                autoComplete='off'
                                onChange={this.handleInput}
                            />
                            <button className='btn btn-primary' onClick={this.toggleShow}>Enter</button>
                        </div>
                        :
                        <div>
                            <StudentTable studentsData={studentsData} />
                            <Calculator />
                            <GrandChild name={this.state.name} show={this.state.show} onBack={this.toggleShow} clearInputFiled={this.clearInputFiled} />
                        </div>

                }
            </>
        )
    }
}
export default Child