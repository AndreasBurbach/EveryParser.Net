grammar EveryGrammar;
startRule: (expression NEWLINE)*;
expression:
   if_else;
   
if_else:
   inner_if_else
   | bool_or_term QUESTIONMARK inner_if_else COLON inner_if_else;

inner_if_else:
   bool_or_term
   | ROUNDBRACKETOPEN if_else ROUNDBRACKETCLOSED;

bool_or_term:
   bool_and_term
   | bool_and_term BOOLOR bool_and_term;

bool_and_term: 
   equality
   | bool_and_term BOOLAND equality;

equality:
	check
	| equality EQUAL check
	| equality NOTEQUAL check
   | ROUNDBRACKETOPEN factor ROUNDBRACKETCLOSED CONTAINS array_expr
   | ROUNDBRACKETOPEN factor ROUNDBRACKETCLOSED NOT CONTAINS array_expr;

check:
	bit_or_term
	| check LOWER bit_or_term
	| check GREATER bit_or_term
	| check LOWEREQUAL bit_or_term
	| check GREATEREQUAL bit_or_term;

bit_or_term:
   bit_and_term
   | bit_or_term BITOR bit_and_term;

bit_and_term:
   line_term
   | bit_and_term BITAND line_term;

line_term:
	point_term
	| line_term ADD point_term
	| line_term SUBTRACT point_term
   | (STRING|VARIABLE) CONCAT point_term ROUNDBRACKETCLOSED
   | (STRING|VARIABLE) UPPERCASE (STRING|VARIABLE) ROUNDBRACKETCLOSED
   | (STRING|VARIABLE) LOWERCASE (STRING|VARIABLE) ROUNDBRACKETCLOSED;

point_term:
	factor
	| point_term MULITPLY factor
	| point_term MODULO factor
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
	| array_expr;

expr_args:
   expression
   | expression KOMMA expr_args;

array_expr: EDGEBRACKETOPEN expr_args EDGEBRACKETCLOSED;


NEWLINE: [\r\n]+;
INT: [0-9]+;
ADD: '+';
SUBTRACT: '-';
MULITPLY: '*';
DIVIDE: '/';
MODULO: '%';
EQUAL: '==';
NOT: 'not';
KOMMA: ',';
NOTEQUAL: '!=';
CONTAINS: 'in';
BOOLOR: '||';
BOOLAND: '&&';
BITOR: '|';
BITAND: '&';
MAX: 'max';
MIN: 'min';
TRUE: 'true';
FALSE: 'false';
GREATER: '>';
GREATEREQUAL: '>=';
LOWER: '<';
LOWEREQUAL: '<=';
ROUNDBRACKETOPEN: '(';
ROUNDBRACKETCLOSED: ')';
EDGEBRACKETOPEN: '[';
EDGEBRACKETCLOSED: ']';
TILDE: '~';
COLON: ':';
QUESTIONMARK: '?';
CONCAT: 'concat(';
UPPERCASE: 'upper(';
LOWERCASE: 'lower(';
INTEGERDIVISION: '//';
DOUBLE: [0-9]+'.'[0-9]+;
STRING : '"' ( '\\"' | . )*? '"' ;
VARIABLE: ALPHA (ALPHA|DIGIT)*;
DIGIT: [0-9];
ALPHA: [a-zA-Z_];