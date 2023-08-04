// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace differ.math {
	public class Util : global::haxe.lang.HxObject {
		
		public Util(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Util() {
			global::differ.math.Util.__hx_ctor_differ_math_Util(this);
		}
		
		
		public static void __hx_ctor_differ_math_Util(global::differ.math.Util __hx_this) {
		}
		
		
		public static double vec_lengthsq(double x, double y) {
			return ( ( x * x ) + ( y * y ) );
		}
		
		
		public static double vec_length(double x, double y) {
			return global::System.Math.Sqrt(((double) (( ( x * x ) + ( y * y ) )) ));
		}
		
		
		public static double vec_normalize(double length, double component) {
			if (( length == 0 )) {
				return ((double) (0) );
			}
			
			component /= length;
			return component;
		}
		
		
		public static double vec_dot(double x, double y, double otherx, double othery) {
			return ( ( x * otherx ) + ( y * othery ) );
		}
		
		
	}
}


