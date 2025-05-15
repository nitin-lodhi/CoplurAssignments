import React, { Component } from 'react'

export default class Child extends Component {
    constructor (props){
        super(props)
    }
  render() {
    return (
      <>
        <div style={{display: 'grid', gridTemplateColumns: 'repeat(3, 1fr)', gap: "2.4rem", margin: "4rem"}} >
            {
          this.props.render(this.props.data) 
        }
        </div>
      </>
    )
  }
}
