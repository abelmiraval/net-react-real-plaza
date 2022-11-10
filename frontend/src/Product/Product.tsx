import React from 'react';
import ProductContainer from './components/ProductContainer';
import { ProductProvider } from './context/ProductProvider';

export const Product = () => {
	return (
		<ProductProvider>
			<ProductContainer></ProductContainer>
		</ProductProvider>
	);
};
