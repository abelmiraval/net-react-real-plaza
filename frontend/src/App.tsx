import React from 'react';
import './App.css';
import Navbar from './Navbar/components/Navbar';
import { Product } from './Product/Product';

function App() {
	return (
		<div className="App">
			<Navbar></Navbar>
			<Product></Product>
		</div>
	);
}

export default App;
