export interface OurService {
  name: string;
  reviews: number;
  totalEnrollment: number;
  startDate: string;
  category: {
    name: string;
  };
  image: string | null;
}
