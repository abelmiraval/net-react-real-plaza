import { createContext } from 'react';
import { Product, ProductState } from '../interfaces/interfaces';

export type ProductContextProps = {
	productState: ProductState;
	getAllProducts: () => Promise<void>;
};

export const ProductContext = createContext<ProductContextProps>({} as ProductContextProps);
