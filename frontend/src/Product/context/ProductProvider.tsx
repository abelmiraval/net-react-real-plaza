import React, { useReducer } from 'react';
import { ProductResponse, ProductState } from '../interfaces/interfaces';
import { ProductContext } from './ProductContext';
import { productReducer } from './productReducer';
import API from '../../api/api';

const INITIAL_STATE: ProductState = {
	products: [],
	price: 3000,
	minPrice: 2000,
	maxPrice: 9000,
	orderBy: 'DESC'
};

interface props {
	children: JSX.Element | JSX.Element[];
}

export const ProductProvider = ({ children }: props) => {
	const [productState, dispatch] = useReducer(productReducer, INITIAL_STATE);

	// const handleChange = (id: string) => {
	// 	dispatch({ type: 'handleChange', payload: { id } });
	// };

	const getAllProducts = async () => {
		const response = await API.get<ProductResponse>('/products?page=1&rows=10&orderBy=DESC&price=0');
		const products = response.data.result.map((result) => {
			const { id, name, category, price, createdAt } = result;
			return {
				id,
				name,
				category,
				price,
				createdAt
			};
		});
		dispatch({ type: 'SET_PRODUCTS', payload: { products } });
	};

	return <ProductContext.Provider value={{ productState, getAllProducts }}>{children}</ProductContext.Provider>;
};
