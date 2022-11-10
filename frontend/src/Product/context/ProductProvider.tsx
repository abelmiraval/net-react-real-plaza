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
	orderBy: 'DESC',
	page: 1,
	totalPage: 1
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

	const getAllProducts = async (orderBy: string, price: number, page: number) => {
		const response = await API.get<ProductResponse>(`/products?page=${page}&rows=6&orderBy=${orderBy}&price=${price}`);
		const products = response.data.result.map((result) => {
			const { id, name, avatar, category, price, createdAt } = result;
			return {
				id,
				name,
				avatar,
				category,
				price,
				createdAt
			};
		});
		const totalPage = response.data.totalPages;
		// const maxPrice = Math.max(...products.map((item) => item.price));
		dispatch({ type: 'SET_TOTAL_PAGE', payload: { totalPage } });
		dispatch({ type: 'SET_PRODUCTS', payload: { products } });
	};

	const nextPage = () => {
		const page = 1;
		dispatch({ type: 'SET_PAGE', payload: { page } });
	};

	const prevPage = () => {
		const page = -1;
		dispatch({ type: 'SET_PAGE', payload: { page } });
	};

	return (
		<ProductContext.Provider
			value={{ productState, getAllProducts, handleChangeInput, handleChangeSelect, nextPage, prevPage }}
		>
			{children}
		</ProductContext.Provider>
	);
};
