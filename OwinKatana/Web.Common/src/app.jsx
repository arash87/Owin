import React, { Component } from 'react'
import ReactDOM from 'react-dom'
import BasicExample from './BasicRoutingExample.jsx'

class App extends Component {
	constructor(props) {
		super(props)
	}

	render() {
		return (
			<h2>React is in its place!!!</h2>
			)
	}
}

ReactDOM.render(<BasicExample />, document.getElementById('root'));

