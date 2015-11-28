#define TRIM_SPACE " \t\n\v"
#include <iostream>
#include <algorithm>
#include <string>
#include <vector>
using namespace std;

FILE* fp;
int ip;
vector<string> v;
inline std::string trim(std::string& s, const std::string& drop = TRIM_SPACE)
{
	std::string r = s.erase(s.find_last_not_of(drop) + 1);
	return r.erase(0, r.find_first_not_of(drop));
}
inline std::string rtrim(std::string s, const std::string& drop = TRIM_SPACE)
{
	return s.erase(s.find_last_not_of(drop) + 1);
}
inline std::string ltrim(std::string s, const std::string& drop = TRIM_SPACE)
{
	return s.erase(0, s.find_first_not_of(drop));
}

int getBarNum(string s)
{
	int res = 0;
	for (int i = 0; i < s.size(); i++)
	{
		if (s[i] == '|')
			res++;
	}
	return res;
}

string getCond1(string s)
{
	cout << s << endl;
	int i = 3;
	string res = "";
	for (; i < s.size(); i++)
	{
		if (s[i] != '=')
			res += s[i];
		else
			break;
	}
	return trim(res);
}
string getCond2ex(string s)
{
	int i = 0;
	for (i = 0; i < s.size(); i++)
	{
		if (s[i] != '=')
			continue;
		break;
	}
	i++;
	string res = "";
	for (; i < s.size(); i++)
		res += s[i];
	return trim(res);
}

string getCond2(string s)
{
	int i = 0;
	for (i = 0; i < s.size(); i++)
	{
		if (s[i] != '=')
			continue;
		break;
	}
	i++;
	string res = "";
	for (; i < s.size() && s[i] != 't' && s[i + 1] != 'h' && s[i+2] != 'e' && s[i+3] != 'n'; i++)
		res += s[i];
	return trim(res);
}

string getStmt(string s)
{
	int i = 0;
	for (i = 0; i < s.size(); i++)
	{
		if (s[i] != 't'
			&& s[i+1] != 'h'
			&& s[i+2] != 'e'
			&& s[i+3] != 'n'
			)
			continue;
		break;
	}
	i+=4;
	string res = "";
	for (;  i < s.size(); i++)
		res += s[i];
	return trim(res);
}

bool isColon(string s)
{
	int i;
	for (i = 0; i < s.size(); i++)
		if (s[i] == ':')
			return true;
	return false;
}

bool hasThen(string s)
{
	try
	{
		for (int i = 0; i < s.size() - 4; i++)
		{
			if (s[i] == 't'
				&& s[i + 1] == 'h'
				&& s[i + 2] == 'e'
				&& s[i + 3] == 'n'
				)
				return true;
		}
		return false;
	}
	catch (exception e)
	{
		return false;
	}
}

void parse(int depth)
{
	bool f = false;
	while (ip < v.size() - 1)
	{
		string cond1 = getCond1(v[ip]);
		string cond2, stmt;
		if (hasThen(v[ip]))
		{
			cond2 = getCond2(v[ip]);
			stmt = getStmt(v[ip]);
			fprintf(fp, "if(%s == \"%s\")\n", cond1.c_str(), cond2.c_str());
			fprintf(fp, "res += \"%s\\n\";\n", stmt.c_str());
		}
		else
		{
			cond2 = getCond2ex(v[ip]);
			fprintf(fp, "if(%s == \"%s\"\n", cond1.c_str(), cond2.c_str());
			ip++;
			while (!hasThen(v[ip]))
			{
				cond1 = getCond1(v[ip]);
				cond2 = getCond2ex(v[ip]);
				fprintf(fp, "&& %s == \"%s\"\n", cond1.c_str(), cond2.c_str());
				ip++;
			}
			cond1 = getCond1(v[ip]);
			cond2 = getCond2(v[ip]);
			stmt = getStmt(v[ip]);
			fprintf(fp, "&& %s == \"%s\")\n", cond1.c_str(), cond2.c_str());
			fprintf(fp, "res += \"%s\\n\";\n", stmt.c_str());
		}
		ip++;
	}
}

int main()
{
	fp = fopen("output.cpp", "w");
	string s;
	while (!cin.eof()) {
		getline(cin, s, '\n');
		v.emplace_back(trim(s));
	}
	parse(0);
}
