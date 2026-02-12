grammar EveryGrammar;
startRule: expression; //Multiline not allowed
expression: if_else;

if_else:
	inner_if_else # IfElse_Next
	| inner_if_else array_slicing_term # ArraySlicing
	| inner_if_else QUESTIONMARK inner_if_else COLON inner_if_else # IfElse;

inner_if_else: bool_or_term # InnerIfElse_Next | ROUNDBRACKETOPEN if_else ROUNDBRACKETCLOSED # InnerIfElse;

bool_or_term: bool_xor_term # BoolOr_Next | bool_xor_term BOOLOR bool_xor_term # BoolOr;

bool_xor_term: bool_and_term # BoolXOr_Next | bool_and_term BOOLXOR bool_and_term # BoolXOr;

bool_and_term: equality # BoolAnd_Next | bool_and_term BOOLAND equality # BoolAnd;

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

bit_or_term: bit_and_term # BitOr_Next | bit_or_term BITOR bit_and_term # BitOR;

bit_and_term: line_term # BitAnd_Next | bit_and_term BITAND line_term # BitAnd;

line_term: point_term # Line_Next | line_term ADD point_term # Line_Addition | line_term SUBTRACT point_term # Line_Subtraction;

point_term:
	factor								# PointTerm_Next
	| point_term MULTIPLY factor		# PointTerm_Multiply
	| point_term POWEROPERATOR factor	# PointTerm_PowerOperator
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
	| FACTORIAL factor									# Factor_Factorial
	| ROUNDBRACKETOPEN expression ROUNDBRACKETCLOSED	# Factor_Brackets
	| TRUE												# Factor_True
	| FALSE												# Factor_False
	| INT												# Factor_Integer
	| DOUBLE											# Factor_Double
	| VARIABLE											# Factor_Variable
	| OBJECTSVARIABLE									# Factor_ObjectVariables
	| STRING											# Factor_String
	| datetime_term										# Factor_DateTimeTerm
	| array_expr										# Factor_Array
	| default_function_term								# Factor_DefaultFunction
	| check_function_term								# Factor_CheckFunction
	| convert_function_term								# Factor_ConvertFunction
	| math_function_term								# Factor_MathFunction
	| random_function_term								# Factor_RandomFunction
	| statistic_math_function_term						# Factor_StatisticMathFunction;

random_function_term:
	RndDecimal ROUNDBRACKETCLOSED													# Random_Decimal
	| RndDecimal expression ROUNDBRACKETCLOSED										# Random_DecimalArray
	| RndDecimal expression KOMMA expression ROUNDBRACKETCLOSED						# Random_DecimalMinMax
	| RndDecimal expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# Random_DecimalArrayMinMax
	| RndInteger ROUNDBRACKETCLOSED													# Random_Integer
	| RndInteger expression ROUNDBRACKETCLOSED										# Random_IntegerArray
	| RndInteger expression KOMMA expression ROUNDBRACKETCLOSED						# Random_IntegerMinMax
	| RndInteger expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# Random_IntegerArrayMinMax;

convert_function_term:
	ToArray expr_args ROUNDBRACKETCLOSED			# Convert_ToArray
	| ToBoolean expression ROUNDBRACKETCLOSED		# Convert_ToBoolean
	| ToNumber expression ROUNDBRACKETCLOSED		# Convert_ToNumber
	| ToString expression ROUNDBRACKETCLOSED		# Convert_ToString
	| DegreeToGrad expression ROUNDBRACKETCLOSED	# Convert_DegreeToGrad
	| DegreeToRadian expression ROUNDBRACKETCLOSED	# Convert_DegreeToRadian
	| GradToDegree expression ROUNDBRACKETCLOSED	# Convert_GradToDegree
	| GradToRadian expression ROUNDBRACKETCLOSED	# Convert_GradToRadian
	| RadianToDegree expression ROUNDBRACKETCLOSED	# Convert_RadianToDegree
	| RadianToGrad expression ROUNDBRACKETCLOSED	# Convert_RadianToGrad;

datetime_term:
	DateTime expression ROUNDBRACKETCLOSED																											# DateTime_Expression
	| DateTime expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED																		# DateTime_DateEntry
	| DateTime expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED														# DateTime_DateHour
	| DateTime expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED									# DateTime_DateHourMinute
	| DateTime expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED					# DateTime_DateHourMinuteSeconds
	| DateTime expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# DateTime_Full;

array_slicing_term:
	EDGEBRACKETOPEN expression EDGEBRACKETCLOSED										# ArraySlicing_Indexing
	| EDGEBRACKETOPEN expression COLON expression EDGEBRACKETCLOSED						# ArraySlicing_Slicing
	| EDGEBRACKETOPEN expression COLON expression COLON expression EDGEBRACKETCLOSED	# ArraySlicing_StepSlicing
	| EDGEBRACKETOPEN expression COLON EDGEBRACKETCLOSED								# ArraySlicing_StartSlicing
	| EDGEBRACKETOPEN expression COLON COLON expression EDGEBRACKETCLOSED				# ArraySlicing_StartStepSlicing
	| EDGEBRACKETOPEN COLON expression EDGEBRACKETCLOSED								# ArraySlicing_EndSlicing
	| EDGEBRACKETOPEN COLON expression COLON expression EDGEBRACKETCLOSED				# ArraySlicing_EndStepSlicing
	| EDGEBRACKETOPEN COLON COLON expression EDGEBRACKETCLOSED							# ArraySlicing_AllStepSlicing;

check_function_term:
	IsArray expression ROUNDBRACKETCLOSED			# CheckFunction_IsArray
	| IsBoolean expression ROUNDBRACKETCLOSED		# CheckFunction_IsBoolean
	| IsDateTime expression ROUNDBRACKETCLOSED		# CheckFunction_IsDateTime
	| IsNull expression ROUNDBRACKETCLOSED			# CheckFunction_IsNull
	| IsNumber expression ROUNDBRACKETCLOSED		# CheckFunction_IsNumber
	| IsString expression ROUNDBRACKETCLOSED		# CheckFunction_IsString
	| IsWhitespace expression ROUNDBRACKETCLOSED	# CheckFunction_IsWhitespace
	| HasAny expression ROUNDBRACKETCLOSED			# CheckFunction_HasAny
	| HasDuplicates expression ROUNDBRACKETCLOSED	# CheckFunction_HasDuplicates;

default_function_term:
	Concat expression KOMMA expression ROUNDBRACKETCLOSED										# Function_Concat
	| Count expression ROUNDBRACKETCLOSED														# Function_Count
	| Distinct expression ROUNDBRACKETCLOSED													# Function_Distinc
	| Difference expression KOMMA expression ROUNDBRACKETCLOSED									# Function_Difference
	| Except expression KOMMA expression ROUNDBRACKETCLOSED										# Function_Except
	| IndexOf expression KOMMA expression ROUNDBRACKETCLOSED									# Function_IndexOf
	| IndexOf expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED					# Function_IndexOfStart
	| IndexOf expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# Function_IndexOfStartEnd
	| LowerCase expression ROUNDBRACKETCLOSED													# Function_Lower
	| Reverse expression ROUNDBRACKETCLOSED														# Function_Reverse
	| UpperCase expression ROUNDBRACKETCLOSED													# Function_Upper
	| Sort expression ROUNDBRACKETCLOSED														# Function_Sort
	| Trim expression ROUNDBRACKETCLOSED														# Function_Trim;

math_function_term:
	Abs expression ROUNDBRACKETCLOSED																# Math_Abs
	| ACos expression ROUNDBRACKETCLOSED															# Math_ACos
	| ACosH expression ROUNDBRACKETCLOSED															# Math_ACosH
	| ASin expression ROUNDBRACKETCLOSED															# Math_ASin
	| ASinH expression ROUNDBRACKETCLOSED															# Math_ASinH
	| ATan expression ROUNDBRACKETCLOSED															# Math_ATan
	| ATan2 expression KOMMA expression ROUNDBRACKETCLOSED											# Math_ATan2
	| ATanH expression ROUNDBRACKETCLOSED															# Math_ATanH
	| Cbrt expression ROUNDBRACKETCLOSED															# Math_Cbrt
	| Cos expression ROUNDBRACKETCLOSED																# Math_Cos
	| CosH expression ROUNDBRACKETCLOSED															# Math_CosH
	| Ceilling expression ROUNDBRACKETCLOSED														# Math_Ceilling
	| Clamp expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED							# Math_Clamp
	| CrossSum expression ROUNDBRACKETCLOSED														# Math_CrossSum
	| Derivative expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED					# Math_Derivative
	| Exp expression ROUNDBRACKETCLOSED																# Math_Exp
	| Floor expression ROUNDBRACKETCLOSED															# Math_Floor
	| Integration expression KOMMA expression KOMMA expression KOMMA expression ROUNDBRACKETCLOSED	# Math_Integration
	| Log expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Log
	| Log2 expression ROUNDBRACKETCLOSED															# Math_Log2
	| Log10 expression ROUNDBRACKETCLOSED															# Math_Log10
	| Max expression ROUNDBRACKETCLOSED																# Math_Max_Array
	| Max expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Max_Two
	| Min expression ROUNDBRACKETCLOSED																# Math_Min_Array
	| Min expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Min_Two
	| Power expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Power
	| Round expression ROUNDBRACKETCLOSED															# Math_Round_Not_Decimal
	| Round expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Round_Decimal
	| Root expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Root
	| Sin expression ROUNDBRACKETCLOSED																# Math_Sin
	| SinH expression ROUNDBRACKETCLOSED															# Math_SinH
	| Sqrt expression ROUNDBRACKETCLOSED															# Math_Sqrt
	| Tan expression ROUNDBRACKETCLOSED																# Math_Tan
	| TanH expression ROUNDBRACKETCLOSED															# Math_TanH
	| Truncate expression ROUNDBRACKETCLOSED														# Math_Truncate
	| Norm expression KOMMA expression ROUNDBRACKETCLOSED											# Math_Norm
	| EulerNorm expression ROUNDBRACKETCLOSED														# Math_EulerNorm
	| MaxNorm expression ROUNDBRACKETCLOSED															# Math_MaxNorm
	| GreatestCommonDivisor expression KOMMA expression ROUNDBRACKETCLOSED							# Math_GreatesCommonDivisor
	| LeastCommonMultiple expression KOMMA expression ROUNDBRACKETCLOSED							# Math_LeastCommonMultiple
	| DotProduct expression KOMMA expression ROUNDBRACKETCLOSED										# Math_DotProduct
	| Binomial expression KOMMA expression ROUNDBRACKETCLOSED										# Math_Binomila
	| ACot expression ROUNDBRACKETCLOSED															# Math_ACot
	| ACotH expression ROUNDBRACKETCLOSED															# Math_ACotH
	| ACsc expression ROUNDBRACKETCLOSED															# Math_ACsc
	| ACscH expression ROUNDBRACKETCLOSED															# Math_ACscH
	| ASec expression ROUNDBRACKETCLOSED															# Math_ASec
	| ASecH expression ROUNDBRACKETCLOSED															# Math_ASecH
	| Cot expression ROUNDBRACKETCLOSED																# Math_Cot
	| CotH expression ROUNDBRACKETCLOSED															# Math_CotH
	| Csc expression ROUNDBRACKETCLOSED																# Math_Csc
	| CscH expression ROUNDBRACKETCLOSED															# Math_CscH
	| Sec expression ROUNDBRACKETCLOSED																# Math_Sec
	| SecH expression ROUNDBRACKETCLOSED															# Math_SecH;

statistic_math_function_term:
	CoVariance expression KOMMA expression ROUNDBRACKETCLOSED	# MathStatistic_CoVariance
	| Mean expression ROUNDBRACKETCLOSED						# MathStatistic_Mean
	| Median expression ROUNDBRACKETCLOSED						# MathStatistic_Median
	| Pearson expression KOMMA expression ROUNDBRACKETCLOSED	# MathStatistic_Pearson
	| Quantil expression KOMMA expression ROUNDBRACKETCLOSED	# MathStatistic_Quantil
	| Spearman expression KOMMA expression ROUNDBRACKETCLOSED	# MathStatistic_Spearman
	| Std expression ROUNDBRACKETCLOSED							# MathStatistic_StD
	| Variance expression ROUNDBRACKETCLOSED					# MathStatistic_Variance;

expr_args: expression | expression KOMMA expr_args;

array_expr: EDGEBRACKETOPEN EDGEBRACKETCLOSED # ArrayCreation_Empty | EDGEBRACKETOPEN expr_args EDGEBRACKETCLOSED # ArrayCreation;

//TOKENS

//operators
ADD: '+';
SUBTRACT: '-';
MULTIPLY: '*';
DIVIDE: '/';
MODULO: '%';
POWEROPERATOR: '**';
BOOLXOR: '^';
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
FACTORIAL: '!';

//default types and constants NEWLINE: [\r\n]+; //Multiline is not allowed in the grammar
KOMMA: ',';
TRUE: 'true';
FALSE: 'false';
//WHITESPACE: [\s]+;

//brackets
ROUNDBRACKETOPEN: '(';
ROUNDBRACKETCLOSED: ')';
EDGEBRACKETOPEN: '[';
EDGEBRACKETCLOSED: ']';
DOUBLE: INT '.' INT;
STRING: '"' ( '\\"' | .)*? '"';
VARIABLE: ALPHA (ALPHA | INT)*;
OBJECTSVARIABLE: VARIABLE ('.' VARIABLE)+;
INT: [0-9]+;
ALPHA: [a-zA-Z_];

//math constants
E: 'e';
PI: 'pi';

//default math function tokens
Abs: 'Abs(';
ACos: 'ACos(';
ACosH: 'ACosH(';
ASin: 'ASin(';
ASinH: 'ASinH(';
ATan: 'ATan(';
ATan2: 'ATan2(';
ATanH: 'ATanH(';
Cbrt: 'Cbrt(';
Cos: 'Cos(';
CosH: 'CosH(';
Ceilling: 'Ceilling(';
Clamp: 'Clamp(';
CrossSum: 'CrossSum(';
Derivative: 'Derivative(';
Exp: 'Exp(';
Floor: 'Floor(';
Integration: 'Integration(';
Log: 'Log(';
Log2: 'Log2(';
Log10: 'Log10(';
Max: 'Max(';
Min: 'Min(';
Power: 'Pow(';
Round: 'Round(';
Root: 'Root(';
Sin: 'Sin(';
SinH: 'SinH(';
Sqrt: 'Sqrt(';
Tan: 'Tan(';
TanH: 'TanH(';
Truncate: 'Truncate(';
Norm: 'Norm(';
EulerNorm: 'EulerNorm(';
MaxNorm: 'MaxNorm(';
GreatestCommonDivisor: 'Gcd(';
LeastCommonMultiple: 'Lcm(';
DotProduct: 'DotProduct(';
Binomial: 'Binomial(';
ACot: 'ACot(';
ACotH: 'ACotH(';
ACsc: 'ACsc(';
ACscH: 'ACscH(';
ASec: 'ASec(';
ASecH: 'ASecH(';
Cot: 'Cot(';
CotH: 'CotH(';
Csc: 'Csc(';
CscH: 'CscH(';
Sec: 'Sec(';
SecH: 'SecH(';

//statistic math function tokens
CoVariance: 'CoVariance(';
Mean: 'Mean(';
Median: 'Median(';
Pearson: 'Pearson(';
Quantil: 'Quantil(';
Spearman: 'Spearman(';
Std: 'Std(';
Variance: 'Variance(';

//default function tokens
Concat: 'Concat(';
Count: 'Count(';
Distinct: 'Distinct(';
Difference: 'Difference(';
HasDuplicates: 'HasDuplicates(';
DateTime: 'DateTime(';
Except: 'Except(';
IndexOf: 'IndexOf(';
LowerCase: 'Lower(';
Reverse: 'Reverse(';
UpperCase: 'Upper(';
HasAny: 'HasAny(';
Sort: 'Sort(';
Trim: 'Trim(';

//check type function tokens
IsString: 'IsString(';
IsNumber: 'IsNumber(';
IsBoolean: 'IsBoolean(';
IsDateTime: 'IsDatetime(';
IsArray: 'IsArray(';
IsNull: 'IsNull(';
IsWhitespace: 'IsWhitespace(';

//converter function tokens
ToNumber: 'ToNumber(';
ToString: 'ToString(';
ToBoolean: 'ToBoolean(';
ToArray: 'ToArray(';
DegreeToGrad: 'DegreeToGrad(';
DegreeToRadian: 'DegreeToRadian(';
GradToDegree: 'GradToDegree(';
GradToRadian: 'GradToRadian(';
RadianToDegree: 'RadianToDegree(';
RadianToGrad: 'RadianToGrad(';

//random function tokens
RndDecimal: 'RndDecimal(';
RndInteger: 'RndInteger(';