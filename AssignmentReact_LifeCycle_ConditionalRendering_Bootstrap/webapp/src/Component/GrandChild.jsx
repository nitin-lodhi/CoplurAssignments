import React, { Component } from 'react'
import "./Child.css"

export default class GrandChild extends Component {

    componentDidMount() {
        if (this.props.name != "") {
            alert(`Welcome, ${this.props.name}`)
        } else {
            alert(`Welcome, Guest`)
        }
    }


    componentWillUnmount() {
        if (this.props.name != "") {
            alert(`Bye, ${this.props.name}`)
        } else {
            alert(`Bye, Guest`)
        }
    }

    handleBack = () => {
        this.props.onBack()
        this.props.clearInputFiled()
    }

    render() {
        return (
            <div>
                <button className='btn btn-primary ' onClick={this.handleBack}>Back</button>
            </div>
        )
    }
}
