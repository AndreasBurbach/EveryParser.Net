grammar EveryGrammar;
startRule: (expression NEWLINE)*;
expression: if_else;

if_else:
	inner_if_else
	| bool_or_term QUESTIONMARK inner_if_else COLON inner_if_else;

inner_if_else:
	bool_or_term
	| ROUNDBRACKETOPEN if_else ROUNDBRACKETCLOSED;

bool_or_term:
	bool_and_term
	| bool_and_term BOOLOR bool_and_term;

bool_and_term: equality | bool_and_term BOOLAND equality;

equality:
	check
	| equality EQUAL check
	| equality NOTEQUAL check
	| factor CONTAINS factor
	| factor NOT CONTAINS factor;

check:
	bit_or_term
	| check LOWER bit_or_term
	| check GREATER bit_or_term
	| check LOWEREQUAL bit_or_term
	| check GREATEREQUAL bit_or_term;

bit_or_term: bit_and_term | bit_or_term BITOR bit_and_term;

bit_and_term: line_term | bit_and_term BITAND line_term;

line_term:
	point_term
	| line_term ADD point_term
	| line_term SUBTRACT point_term;

point_term:
	factor
	| point_term MULITPLY factor
	| point_term POWEROPERATOR factor
	| point_term MODULO factor
	| point_term BITSHIFTLEFT factor
	| point_term BITSHIFTRIGHT factor
	| point_term DIVIDE factor
	| point_term INTEGERDIVISION factor;

factor:
	NOT factor
	| SUBTRACT factor
	| ADD factor
	| TILDE factor
	| ROUNDBRACKETOPEN expression ROUNDBRACKETCLOSED
	| TRUE
	| FALSE
	| INT
	| DOUBLE
	| VARIABLE
	| STRING
	| array_expr
	| default_function_term
	| math_function_term;

default_function_term:
	 CONCAT expression KOMMA expression ROUNDBRACKETCLOSED #Function_Concat
	| UPPERCASE expression ROUNDBRACKETCLOSED #Function_Upper
	| LOWERCASE expression ROUNDBRACKETCLOSED #Function_Lower
	| DISTINCT expression ROUNDBRACKETCLOSED #Function_Distinc
	| UNION expression KOMMA expression ROUNDBRACKETCLOSED #Function_Concat;

math_function_term:
	ABS expression ROUNDBRACKETCLOSED #Math_Abs
	| ACOS expression ROUNDBRACKETCLOSED #Math_ACos
	| ACOSH expression ROUNDBRACKETCLOSED #Math_ACosH
	| ASIN expression ROUNDBRACKETCLOSED #Math_ASin
	| ASINH expression ROUNDBRACKETCLOSED #Math_ASinH
	| ATAN expression ROUNDBRACKETCLOSED #Math_ATan
	| ATAN2 expression KOMMA expression ROUNDBRACKETCLOSED #Math_ATan2
	| ATANH expression ROUNDBRACKETCLOSED #Math_ATanH
	| CBRT expression ROUNDBRACKETCLOSED #Math_Cbrt
	| COS expression ROUNDBRACKETCLOSED #Math_Cos
	| COSH expression ROUNDBRACKETCLOSED #Math_CosH
	| CEILLING expression ROUNDBRACKETCLOSED #Math_Ceilling
	| CLAMP expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED #Math_Clamp
	| EXP expression ROUNDBRACKETCLOSED #Math_Exp
	| FLOOR expression ROUNDBRACKETCLOSED #Math_Floor
	| LOG expression KOMMA expression ROUNDBRACKETCLOSED #Math_Log
	| LOG2 expression ROUNDBRACKETCLOSED #Math_Log2
	| LOG10 expression ROUNDBRACKETCLOSED #Math_Log10
	| MAX expression ROUNDBRACKETCLOSED #Math_Max_Array
	| MAX expression KOMMA expression ROUNDBRACKETCLOSED #Math_Max_Two
	| MIN expression ROUNDBRACKETCLOSED #Math_Min_Array
	| MIN expression KOMMA expression ROUNDBRACKETCLOSED #Math_Min_Two
	| POWER expression ROUNDBRACKETCLOSED #Math_Power
	| ROUND expression ROUNDBRACKETCLOSED #Math_Round_Not_Decimal
	| ROUND expression KOMMA expression ROUNDBRACKETCLOSED #Math_Round_Decimal
	| ROOT expression KOMMA expression ROUNDBRACKETCLOSED #Math_Root
	| SIN expression ROUNDBRACKETCLOSED #Math_Sin
	| SINH expression ROUNDBRACKETCLOSED #Math_SinH
	| SQRT expression ROUNDBRACKETCLOSED #Math_Sqrt
	| TAN expression ROUNDBRACKETCLOSED #Math_Tan
	| TANH expression ROUNDBRACKETCLOSED #Math_TanH
	| TRUNCATE expression ROUNDBRACKETCLOSED #Math_Truncate;

expr_args: expression | expression KOMMA expr_args;

array_expr: EDGEBRACKETOPEN expr_args EDGEBRACKETCLOSED;

//TOKENS

//operators
ADD: '+';
SUBTRACT: '-';
MULITPLY: '*';
DIVIDE: '/';
MODULO: '%';
POWEROPERATOR: '^';
EQUAL: '==';
NOT: 'not';
NOTEQUAL: '!=';
BOOLOR: '||';
BOOLAND: '&&';
BITOR: '|';
BITAND: '&';
GREATER: '>';
GREATEREQUAL: '>=';
LOWER: '<';
LOWEREQUAL: '<=';
TILDE: '~';
COLON: ':';
QUESTIONMARK: '?';
INTEGERDIVISION: '//';
BITSHIFTLEFT: '<<';
BITSHIFTRIGHT: '>>';

//default types and constants
NEWLINE: [\r\n]+;
KOMMA: ',';
TRUE: 'true';
FALSE: 'false';

//brackets
ROUNDBRACKETOPEN: '(';
ROUNDBRACKETCLOSED: ')';
EDGEBRACKETOPEN: '[';
EDGEBRACKETCLOSED: ']';
DOUBLE: [0-9]+ '.' [0-9]+;
STRING: '"' ( '\\"' | .)*? '"';
VARIABLE: ALPHA (ALPHA | DIGIT)*;
DIGIT: [0-9];
ALPHA: [a-zA-Z_];
INT: DIGIT+;

//math constants
E: 'e';
PI: 'pi';

//default math function tokens
ABS: 'abs(';
ACOS: 'acos(';
ACOSH: 'acosh(';
ASIN: 'asin(';
ASINH: 'asinh(';
ATAN: 'atan(';
ATAN2: 'atan2(';
ATANH: 'atanh(';
CBRT: 'cbrt(';
COS: 'cos(';
COSH: 'cosh(';
CEILLING: 'ceilling(';
CLAMP: 'clamp(';
EXP: 'exp(';
FLOOR: 'floor(';
LOG: 'log(';
LOG2: 'log2(';
LOG10: 'log10(';
MAX: 'max(';
MIN: 'min(';
POWER: 'pow(';
ROUND: 'round(';
ROOT: 'root(';
SIN: 'sin(';
SINH: 'sinh(';
SQRT: 'sqrt(';
TAN: 'tan(';
TANH: 'tanh(';
TRUNCATE: 'truncate(';

//statistic math function tokens
MEAN: 'mean(';
MEDIAN: 'median(';
VARIANCE: 'variance(';

//default function tokens
CONCAT: 'concat(';
UPPERCASE: 'upper(';
LOWERCASE: 'lower(';
CONTAINS: 'in';
DISTINCT: 'distinct(';
UNION: 'union';
