export interface Product {
	id: number;
	name: string;
	price: number;
	category: string;
	createdAt: string;
}

export interface ProductState {
	products: Product[];
	price: number;
	minPrice: number;
	maxPrice: number;
	orderBy: string;
}

export type ProductResponse = {
	totalPages: number;
	result: Array<{
		id: number;
		name: string;
		price: number;
		category: string;
		createdAt: string;
	}>;
};
