import React, { ChangeEvent } from 'react';
import { Product, ProductState } from '../interfaces/interfaces';

type ProductAction =
	| { type: 'HANDLE_CHANGE_SELECT'; payload: { e: ChangeEvent<HTMLSelectElement> } }
	| { type: 'HANDLE_CHANGE_INPUT'; payload: { e: ChangeEvent<HTMLInputElement> } }
	| { type: 'SET_PRODUCTS'; payload: { products: Product[] } }
	| { type: 'SET_TOTAL_PAGE'; payload: { totalPage: number } }
	| { type: 'SET_PAGE'; payload: { page: number } };

export const productReducer = (state: ProductState, action: ProductAction): ProductState => {
	switch (action.type) {
		case 'HANDLE_CHANGE_SELECT':
			return { ...state, orderBy: action.payload.e.target.value };
		case 'HANDLE_CHANGE_INPUT':
			return { ...state, price: parseInt(action.payload.e.target.value) };
		case 'SET_PRODUCTS':
			return { ...state, products: action.payload.products };
		case 'SET_TOTAL_PAGE':
			return { ...state, totalPage: action.payload.totalPage };
		case 'SET_PAGE':
			return { ...state, page: state.page + action.payload.page };
		default:
			return state;
	}
};
