import React from 'react'
import "./Header.css"

const Header = () => {
    return (
        <header className="main-header">
            <div className="header-container">
                <h1 className="logo">Logo</h1>
                <nav className="nav">
                    <ul>
                        <li><a href="#home">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#services">Services</a></li>
                        <li><a href="#contact">Contact</a></li>
                    </ul>
                </nav>
            </div>
        </header>
    )
}

export default Header