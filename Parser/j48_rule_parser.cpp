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
	int i = 0;
	for (i = 0; i < s.size(); i++)
	{
		if (s[i] == ' ' || s[i] == '|')
			continue;
		break;
	}
	string res = "";
	for (; i < s.size() && s[i] != '='; i++)
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
	for (; i < s.size() && s[i] != ':'; i++)
		res += s[i];
	return trim(res);
}

string getStmt(string s)
{
	int i = 0;
	for (i = 0; i < s.size(); i++)
	{
		if (s[i] != ':')
			continue;
		break;
	}
	i++;
	string res = "";
	for (; i < s.size() && s[i] != '('; i++)
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

void parse(int depth)
{
	bool f = false;
	while (ip < v.size())
	{
		int barN = getBarNum(v[ip]);
		if (barN < depth)
			return;
		string cond1 = getCond1(v[ip]);
		string cond2 = getCond2(v[ip]);
		//cout <<"\""<< cond1 <<"\""<< endl;
		//cout <<"\""<< cond2 <<"\""<< endl;
		if (isColon(v[ip]))
		{
			string stmt = getStmt(v[ip++]).c_str();
			if (f)
				fprintf(fp, "else if(%s == \"%s\")\n{\n", cond1.c_str(), cond2.c_str());
			else
				fprintf(fp, "if(%s == \"%s\")\n{\n", cond1.c_str(), cond2.c_str());
			fprintf(fp, "rule += \"If %s is %s -> \";", cond1.c_str(), cond2.c_str());
			fprintf(fp, "\tres+=\"%s\\n\";\n", stmt.c_str());
			fprintf(fp, "\trule+=\"%s\\n\";\n", stmt.c_str());
			fprintf(fp, "}\n");
		}
		else
		{
			ip++;
			if (f)
				fprintf(fp, "else if(%s == \"%s\")\n{\n", cond1.c_str(), cond2.c_str());
			else
				fprintf(fp, "if(%s == \"%s\")\n{\n", cond1.c_str(), cond2.c_str());
			fprintf(fp, "rule += \"If %s is %s -> \";", cond1.c_str(), cond2.c_str());
			parse(depth + 1);
			fprintf(fp, "}\n");
		}
		f = true;
	}
}

int main()
{
	fp = fopen("output.cpp", "w");
	string s;
	while (!cin.eof()) {
		getline(cin, s, '\n');
		v.emplace_back(s);
	}
	parse(0);
}
