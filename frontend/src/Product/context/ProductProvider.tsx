import React, { ChangeEvent, useReducer } from 'react';
import { ProductResponse, ProductState } from '../interfaces/interfaces';
import { ProductContext } from './ProductContext';
import { productReducer } from './productReducer';
import API from '../../api/api';

const INITIAL_STATE: ProductState = {
	products: [],
	price: 0,
	minPrice: 0,
	maxPrice: 9000,
	orderBy: 'DESC'
};

interface props {
	children: JSX.Element | JSX.Element[];
}

export const ProductProvider = ({ children }: props) => {
	const [productState, dispatch] = useReducer(productReducer, INITIAL_STATE);

	const handleChangeSelect = async (e: ChangeEvent<HTMLSelectElement>) => {
		dispatch({ type: 'HANDLE_CHANGE_SELECT', payload: { e } });
	};

	const handleChangeInput = async (e: ChangeEvent<HTMLInputElement>) => {
		dispatch({ type: 'HANDLE_CHANGE_INPUT', payload: { e } });
	};

	const getAllProducts = async (orderBy: string, price: number) => {
		const response = await API.get<ProductResponse>(`/products?page=1&rows=10&orderBy=${orderBy}&price=${price}`);
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
		// const maxPrice = Math.max(...products.map((item) => item.price));
		dispatch({ type: 'SET_PRODUCTS', payload: { products } });
	};

	return (
		<ProductContext.Provider value={{ productState, getAllProducts, handleChangeInput, handleChangeSelect }}>
			{children}
		</ProductContext.Provider>
	);
};
