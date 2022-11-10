import React from 'react';
import { Product, ProductState } from '../interfaces/interfaces';

type ProductAction = { type: 'SET_PRODUCTS'; payload: { products: Product[] } };

export const productReducer = (state: ProductState, action: ProductAction): ProductState => {
	switch (action.type) {
		case 'SET_PRODUCTS':
			return { ...state, products: action.payload.products };
		default:
			return state;
	}
};
