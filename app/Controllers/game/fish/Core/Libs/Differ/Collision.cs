// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace differ {
	public class Collision : global::haxe.lang.HxObject {
		
		public Collision(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Collision() {
			global::differ.Collision.__hx_ctor_differ_Collision(this);
		}
		
		
		public static void __hx_ctor_differ_Collision(global::differ.Collision __hx_this) {
		}
		
		
		public static global::differ.data.ShapeCollision shapeWithShape(global::differ.shapes.Shape shape1, global::differ.shapes.Shape shape2, global::differ.data.ShapeCollision @into) {
			return shape1.test(shape2, @into);
		}
		
		
		public static global::differ.Results_differ_data_ShapeCollision shapeWithShapes(global::differ.shapes.Shape shape1, global::ArrayHaxe<object> shapes, global::differ.Results_differ_data_ShapeCollision @into) {
			global::differ.Results_differ_data_ShapeCollision results = null;
			if (( @into != null )) {
				@into.count = 0;
				results = @into;
			}
			else {
				results = new global::differ.Results_differ_data_ShapeCollision(((int) (shapes.length) ));
			}
			
			{
				int _g = 0;
				while (( _g < shapes.length )) {
					global::differ.shapes.Shape other_shape = ((global::differ.shapes.Shape) (shapes[_g]) );
					 ++ _g;
					if (( results.items.length == results.count )) {
						results.items.push(new global::differ.data.ShapeCollision());
					}
					
					global::differ.data.ShapeCollision @value = ((global::differ.data.ShapeCollision) (results.items[results.count]) );
					global::differ.data.ShapeCollision result = shape1.test(other_shape, @value);
					if (( result != null )) {
						results.items[results.count] = result;
						results.count++;
					}
					
				}
				
			}
			
			return results;
		}
		
		
		public static global::differ.data.RayCollision rayWithShape(global::differ.shapes.Ray ray, global::differ.shapes.Shape shape, global::differ.data.RayCollision @into) {
			return shape.testRay(ray, @into);
		}
		
		
		public static global::differ.Results_differ_data_RayCollision rayWithShapes(global::differ.shapes.Ray ray, global::ArrayHaxe<object> shapes, global::differ.Results_differ_data_RayCollision @into) {
			global::differ.Results_differ_data_RayCollision results = null;
			if (( @into != null )) {
				@into.count = 0;
				results = @into;
			}
			else {
				results = new global::differ.Results_differ_data_RayCollision(((int) (shapes.length) ));
			}
			
			{
				int _g = 0;
				while (( _g < shapes.length )) {
					global::differ.shapes.Shape shape = ((global::differ.shapes.Shape) (shapes[_g]) );
					 ++ _g;
					if (( results.items.length == results.count )) {
						results.items.push(new global::differ.data.RayCollision());
					}
					
					global::differ.data.RayCollision @value = ((global::differ.data.RayCollision) (results.items[results.count]) );
					global::differ.data.RayCollision result = shape.testRay(ray, @value);
					if (( result != null )) {
						results.items[results.count] = result;
						results.count++;
					}
					
				}
				
			}
			
			return results;
		}
		
		
		public static global::differ.data.RayIntersection rayWithRay(global::differ.shapes.Ray ray1, global::differ.shapes.Ray ray2, global::differ.data.RayIntersection @into) {
			return global::differ.sat.SAT2D.testRayVsRay(ray1, ray2, @into);
		}
		
		
		public static global::differ.Results_differ_data_RayIntersection rayWithRays(global::differ.shapes.Ray ray, global::ArrayHaxe<object> rays, global::differ.Results_differ_data_RayIntersection @into) {
			global::differ.Results_differ_data_RayIntersection results = null;
			if (( @into != null )) {
				@into.count = 0;
				results = @into;
			}
			else {
				results = new global::differ.Results_differ_data_RayIntersection(((int) (rays.length) ));
			}
			
			{
				int _g = 0;
				while (( _g < rays.length )) {
					global::differ.shapes.Ray other = ((global::differ.shapes.Ray) (rays[_g]) );
					 ++ _g;
					if (( results.items.length == results.count )) {
						results.items.push(new global::differ.data.RayIntersection());
					}
					
					global::differ.data.RayIntersection @value = ((global::differ.data.RayIntersection) (results.items[results.count]) );
					global::differ.data.RayIntersection result = global::differ.sat.SAT2D.testRayVsRay(ray, other, @value);
					if (( result != null )) {
						results.items[results.count] = result;
						results.count++;
					}
					
				}
				
			}
			
			return results;
		}
		
		
		public static bool pointInPoly(double x, double y, global::differ.shapes.Polygon poly) {
			unchecked {
				int sides = poly.get_transformedVertices().length;
				global::ArrayHaxe<object> verts = poly.get_transformedVertices();
				int i = 0;
				int j = ( sides - 1 );
				bool oddNodes = false;
				{
					int _g1 = 0;
					int _g = sides;
					while (( _g1 < _g )) {
						int i1 = _g1++;
						if (( ( ( ((global::differ.math.Vector) (verts[i1]) ).y < y ) && ( ((global::differ.math.Vector) (verts[j]) ).y >= y ) ) || ( ( ((global::differ.math.Vector) (verts[j]) ).y < y ) && ( ((global::differ.math.Vector) (verts[i1]) ).y >= y ) ) )) {
							if (( ( ((global::differ.math.Vector) (verts[i1]) ).x + ( ( (( y - ((global::differ.math.Vector) (verts[i1]) ).y )) / (( ((global::differ.math.Vector) (verts[j]) ).y - ((global::differ.math.Vector) (verts[i1]) ).y )) ) * (( ((global::differ.math.Vector) (verts[j]) ).x - ((global::differ.math.Vector) (verts[i1]) ).x )) ) ) < x )) {
								oddNodes =  ! (oddNodes) ;
							}
							
						}
						
						j = i1;
					}
					
				}
				
				return oddNodes;
			}
		}
		
		
	}
}

