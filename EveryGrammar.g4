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
	| factor CONTAINS array_expr
	| factor NOT CONTAINS array_expr;

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
	(STRING | VARIABLE) CONCAT point_term ROUNDBRACKETCLOSED
	| (STRING | VARIABLE) UPPERCASE (STRING | VARIABLE) ROUNDBRACKETCLOSED
	| (STRING | VARIABLE) LOWERCASE (STRING | VARIABLE) ROUNDBRACKETCLOSED;

math_function_term:
	ABS factor ROUNDBRACKETCLOSED
	| ACOS factor ROUNDBRACKETCLOSED
	| ACOSH factor ROUNDBRACKETCLOSED
	| ASIN factor ROUNDBRACKETCLOSED
	| ASINH factor ROUNDBRACKETCLOSED
	| ATAN factor ROUNDBRACKETCLOSED
	| ATAN2 factor KOMMA factor ROUNDBRACKETCLOSED
	| ATANH factor ROUNDBRACKETCLOSED
	| CBRT factor ROUNDBRACKETCLOSED
	| COS factor ROUNDBRACKETCLOSED
	| COSH factor ROUNDBRACKETCLOSED
	| CEILLING factor ROUNDBRACKETCLOSED
	| CLAMP factor KOMMA factor KOMMA factor ROUNDBRACKETCLOSED
	| EXP factor ROUNDBRACKETCLOSED
	| FLOOR factor ROUNDBRACKETCLOSED
	| LOG factor KOMMA factor ROUNDBRACKETCLOSED
	| LOG2 factor ROUNDBRACKETCLOSED
	| LOG10 factor ROUNDBRACKETCLOSED
	| MAX factor ROUNDBRACKETCLOSED
	| MAX factor KOMMA factor ROUNDBRACKETCLOSED
	| MIN factor ROUNDBRACKETCLOSED
	| MIN factor KOMMA factor ROUNDBRACKETCLOSED
	| POWER factor ROUNDBRACKETCLOSED
	| ROUND factor ROUNDBRACKETCLOSED
	| ROUND factor KOMMA factor ROUNDBRACKETCLOSED
	| ROOT factor KOMMA factor ROUNDBRACKETCLOSED
	| SIN factor ROUNDBRACKETCLOSED
	| SINH factor ROUNDBRACKETCLOSED
	| SQRT factor ROUNDBRACKETCLOSED
	| TAN factor ROUNDBRACKETCLOSED
	| TANH factor ROUNDBRACKETCLOSED
	| TRUNCATE factor ROUNDBRACKETCLOSED;

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

//math function tokens
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

//default function tokens
CONCAT: 'concat(';
UPPERCASE: 'upper(';
LOWERCASE: 'lower(';
CONTAINS: 'in';
