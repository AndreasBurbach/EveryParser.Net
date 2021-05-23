grammar EveryGrammar;
startRule: (expression NEWLINE)*;
expression: if_else;

if_else:
	inner_if_else													# IfElse_Next
	| inner_if_else array_slicing_term								# ArraySlicing
	| inner_if_else QUESTIONMARK inner_if_else COLON inner_if_else	# IfElse;

inner_if_else:
	bool_or_term									# InnerIfElse_Next
	| ROUNDBRACKETOPEN if_else ROUNDBRACKETCLOSED	# InnerIfElse;

bool_or_term:
	bool_and_term							# BoolOr_Next
	| bool_and_term BOOLOR bool_and_term	# BoolOr;

bool_and_term:
	equality							# BoolAnd_Next
	| bool_and_term BOOLAND equality	# BoolAnd;

equality:
	check									# Equality_Next
	| equality EQUAL check					# Equality_Equal
	| equality NOTEQUAL check				# Equality_NotEqual
	| equality EQUAL_IGNORECASE check		# Equality_EqualIgnoreCase
	| equality NOTEQUAL_IGNORECASE check	# Equality_NotEqualIgnoreCase
	| equality CONTAINS check				# Equality_Contains
	| equality NOT CONTAINS check			# Equality_NotContains;

check:
	bit_or_term							# Check_Next
	| check LOWER bit_or_term			# Check_Lower
	| check GREATER bit_or_term			# Check_Greater
	| check LOWEREQUAL bit_or_term		# Check_LowerEqual
	| check GREATEREQUAL bit_or_term	# Check_GreaterEqual;

bit_or_term:
	bit_and_term						# BitOr_Next
	| bit_or_term BITOR bit_and_term	# BitOR;

bit_and_term:
	line_term						# BitAnd_Next
	| bit_and_term BITAND line_term	# BitAnd;

line_term:
	point_term						# Line_Next
	| line_term ADD point_term		# Line_Addition
	| line_term SUBTRACT point_term	# Line_Subtraction;

point_term:
	factor								# PointTerm_Factor
	| point_term MULTIPLY factor		# PointTerm_Multiply
	| point_term POWEROPERATOR factor	# PointTerm_Multiply
	| point_term MODULO factor			# PointTerm_Modulo
	| point_term BITSHIFTLEFT factor	# PointTerm_BitShiftLeft
	| point_term BITSHIFTRIGHT factor	# PointTerm_BitShiftRight
	| point_term DIVIDE factor			# PointTerm_Divide
	| point_term INTEGERDIVISION factor	# PointTerm_IntegerDivision;

factor:
	NOT factor											# Factor_Not
	| SUBTRACT factor									# Factor_Minus
	| ADD factor										# Factor_Plus
	| TILDE factor										# Factor_Tilde
	| ROUNDBRACKETOPEN expression ROUNDBRACKETCLOSED	# Factor_Brackets
	| TRUE												# Factor_True
	| FALSE												# Factor_False
	| INT												# Factor_Integer
	| DOUBLE											# Factor_Double
	| VARIABLE											# Factor_Variable
	| STRING											# Factor_String
	| datetime_term										# Factor_DateTimeTerm
	| array_expr										# Factor_Array
	| default_function_term								# Factor_DefaultFunction
	| math_function_term								# Factor_MathFunction
	| statistic_math_function_term						# Factor_StatisticMathFunction;

datetime_term:
	DATETIMENOW																					# DateTime_Now
	| DATETIME expression ROUNDBRACKETCLOSED													# DateTime_Expression
	| DATETIME expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED					# DateTime_DateEntry
	| DATETIME expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# DateTime_DateHour
	| DATETIME expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED # DateTime_DateHour
	| DATETIME expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED # DateTime_DateHourMinute
	| DATETIME expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA	expression KOMMA expression ROUNDBRACKETCLOSED # DateTime_DateHourMinuteSeconds
	| DATETIME expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA	expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED # DateTime_Full;

array_slicing_term:
	EDGEBRACKETOPEN expression EDGEBRACKETCLOSED										# ArraySlicing_Indexing
	| EDGEBRACKETOPEN expression COLON expression EDGEBRACKETCLOSED						# ArraySlicing_Slicing
	| EDGEBRACKETOPEN expression COLON expression COLON expression EDGEBRACKETCLOSED	# ArraySlicing_StepSlicing;

default_function_term:
	CONCAT expression KOMMA expression ROUNDBRACKETCLOSED	# Function_Concat
	| COUNT expression ROUNDBRACKETCLOSED					# Function_Count
	| DISTINCT expression ROUNDBRACKETCLOSED				# Function_Distinc
	| DUPLICATES expression ROUNDBRACKETCLOSED				# Function_Duplicates
	| INDEXOF expression ROUNDBRACKETCLOSED					# Function_IndexOf
	| LOWERCASE expression ROUNDBRACKETCLOSED				# Function_Lower
	| REVERSE expression ROUNDBRACKETCLOSED					# Function_Reverse
	| UNION expression KOMMA expression ROUNDBRACKETCLOSED	# Function_Concat
	| UPPERCASE expression ROUNDBRACKETCLOSED				# Function_Upper;

math_function_term:
	ABS expression ROUNDBRACKETCLOSED																# Math_Abs
	| ACOS expression ROUNDBRACKETCLOSED															# Math_ACos
	| ACOSH expression ROUNDBRACKETCLOSED															# Math_ACosH
	| ASIN expression ROUNDBRACKETCLOSED															# Math_ASin
	| ASINH expression ROUNDBRACKETCLOSED															# Math_ASinH
	| ATAN expression ROUNDBRACKETCLOSED															# Math_ATan
	| ATAN2 expression KOMMA expression ROUNDBRACKETCLOSED											# Math_ATan2
	| ATANH expression ROUNDBRACKETCLOSED															# Math_ATanH
	| CBRT expression ROUNDBRACKETCLOSED															# Math_Cbrt
	| COS expression ROUNDBRACKETCLOSED																# Math_Cos
	| COSH expression ROUNDBRACKETCLOSED															# Math_CosH
	| CEILLING expression ROUNDBRACKETCLOSED														# Math_Ceilling
	| CLAMP expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED							# Math_Clamp
	| CROSSSUM expression ROUNDBRACKETCLOSED														# Math_CrossSum
	| DERIVATIVE expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED					# Math_Derivative
	| EXP expression ROUNDBRACKETCLOSED																# Math_Exp
	| FLOOR expression ROUNDBRACKETCLOSED															# Math_Floor
	| INTEGRATION expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Integration
	| LOG expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Log
	| LOG2 expression ROUNDBRACKETCLOSED					# Math_Log2
	| LOG10 expression ROUNDBRACKETCLOSED					# Math_Log10
	| MAX expression ROUNDBRACKETCLOSED						# Math_Max_Array
	| MAX expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Max_Two
	| MIN expression ROUNDBRACKETCLOSED						# Math_Min_Array
	| MIN expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Min_Two
	| POWER expression ROUNDBRACKETCLOSED					# Math_Power
	| ROUND expression ROUNDBRACKETCLOSED					# Math_Round_Not_Decimal
	| ROUND expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Round_Decimal
	| ROOT expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Root
	| SIN expression ROUNDBRACKETCLOSED						# Math_Sin
	| SINH expression ROUNDBRACKETCLOSED					# Math_SinH
	| SQRT expression ROUNDBRACKETCLOSED					# Math_Sqrt
	| TAN expression ROUNDBRACKETCLOSED						# Math_Tan
	| TANH expression ROUNDBRACKETCLOSED					# Math_TanH
	| TRUNCATE expression ROUNDBRACKETCLOSED				# Math_Truncate;

statistic_math_function_term:
	MEAN expression ROUNDBRACKETCLOSED			# MathStatistic_Mean
	| MEDIAN expression ROUNDBRACKETCLOSED		# MathStatistic_Median
	| VARIANCE expression ROUNDBRACKETCLOSED	# MathStatistic_Variance;

expr_args: expression | expression KOMMA expr_args;

array_expr: EDGEBRACKETOPEN expr_args EDGEBRACKETCLOSED;

//TOKENS

//operators
ADD: '+';
SUBTRACT: '-';
MULTIPLY: '*';
DIVIDE: '/';
MODULO: '%';
POWEROPERATOR: '^';
EQUAL: '==';
EQUAL_IGNORECASE: '=i';
NOT: 'not';
NOTEQUAL: '!=';
NOTEQUAL_IGNORECASE: '!=i';
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
CONTAINS: 'in';

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
CROSSSUM: 'crosssum(';
DERIVATIVE: 'derivative(';
EXP: 'exp(';
FLOOR: 'floor(';
INTEGRATION: 'integration(';
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
COUNT: 'count(';
DISTINCT: 'distinct(';
DUPLICATES: 'duplicates(';
DATETIME: 'date';
DATETIMENOW: 'date.now';
INDEXOF: 'indexOf(';
LOWERCASE: 'lower(';
REVERSE: 'reverse(';
UNION: 'union(';
UPPERCASE: 'upper(';